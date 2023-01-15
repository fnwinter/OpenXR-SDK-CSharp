import re
import os

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

def get_enum_name(e):
    _r = re.compile("enum (.*) {", re.MULTILINE)
    name = _r.findall(e)
    return name[0]

def get_enum_key_value(e):
    _r = re.compile("(XR.*) = (.*[^,])[,\n]", re.MULTILINE)
    return _r.findall(e)

def gen_enum(enums):
    with XrTemplate("enum_template.txt") as xr_enum:
        enum_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_enum.cs")

        render_data = []
        for e in enums:
            name = get_enum_name(e)
            value = get_enum_key_value(e)
            render_data.append((name, value))
        
        enum_text = xr_enum.render(render_data = render_data)

        with open(enum_file_path, "w+") as f:
            f.write(enum_text)
