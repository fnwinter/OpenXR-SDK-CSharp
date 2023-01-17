import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

def gen_const(const_list):
    with XrTemplate("const_template.txt") as xr_const:
        const_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_const.cs")

        render_data = []
        for c in const_list:
            render_data.append(c)
        
        const_text = xr_const.render(render_data = render_data)

        with open(const_file_path, "w+") as f:
            f.write(const_text)