import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

replace_type = {
    "const void* XR_MAY_ALIAS" : "IntPtr",
    "void* XR_MAY_ALIAS": "IntPtr",
    "uint32_t" : "uint",
    "uint64_t" : "ulong",
    "char*" : "string",
    "const char*" : "string",
    "uint32_t*" : "UIntPtr",
    "XrBool32" : "uint",
    "const XrVector3f*": "IntPtr",
    "const uint32_t*" : "UIntPtr",
    "const char* const*" : "string",
}

def get_struct_name(struct):
    _r = re.compile("struct (XR_MAY_ALIAS)|( )(\w+) {", re.MULTILINE)
    result = _r.findall(struct)
    return result[0][2] if len(result) == 1 else result[1][2]

def get_type_name(struct):
    _r = re.compile("(^ +)(.*) (.*);", re.MULTILINE)
    results = _r.findall(struct)
    type_list = []
    if results:
        for r in results:
            _type = r[1].strip()
            _name = r[2].strip()
            type_list.append((_type, _name))
        return type_list
    return type_list

def change_pointer_to_array(type, name):
    start = name.find('[')
    end = name.find(']')
    size = name[start + 1:end - 1]
    _name = name[:start]
    return _name + " = new " + type + "[" + size + "]"

def gen_structure(structures):
    with XrTemplate("struct_template.txt") as xr_struct:
        struct_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_struct.cs")

        render_data = []
        for s in structures:
            name_ = get_struct_name(s)
            type_ = get_type_name(s)
            replaced_type_ = []
            for t in type_:
                _type = t[0]
                _name = t[1]
                if '[' in _name or ']' in _name:
                    _name = change_pointer_to_array(_type, _name)
                    _type = _type + "[]"
                if "*" in _type:
                    _type = "IntPtr"

                _t = replace_type.get(_type) if replace_type.get(_type) else _type
                replaced_type_.append((_t, _name))

            render_data.append((name_, replaced_type_))
        
        struct_text = xr_struct.render(render_data = render_data)

        with open(struct_file_path, "w+") as f:
            f.write(struct_text)
