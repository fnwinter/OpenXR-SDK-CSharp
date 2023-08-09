import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

def get_const_string(c):
    _r = re.compile("static const (.+) (.+) = (.+)", re.MULTILINE)
    result = _r.findall(c)[0]
    ret_string = f"static const ulong {result[1]} = {result[2]}"
    return ret_string

def gen_const(const_list):
    with XrTemplate("const_template.txt") as xr_const:
        const_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_const.cs")

        render_data = []
        for c in const_list:
            c_string = get_const_string(c)
            render_data.append(c_string)
        
        const_text = xr_const.render(render_data = render_data)

        with open(const_file_path, "w+") as f:
            f.write(const_text)