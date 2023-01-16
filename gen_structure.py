import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

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

def gen_structure(structures):
    with XrTemplate("struct_template.txt") as xr_struct:
        struct_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_struct.cs")

        render_data = []
        for s in structures:
            name_ = get_struct_name(s)
            type_ = get_type_name(s)
            render_data.append((name_, type_))
        
        struct_text = xr_struct.render(render_data = render_data)

        with open(struct_file_path, "w+") as f:
            f.write(struct_text)
