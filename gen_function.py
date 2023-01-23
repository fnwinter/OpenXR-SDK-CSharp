import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

def get_enum_name(e):
    _r = re.compile("enum (.*) {", re.MULTILINE)
    name = _r.findall(e)
    return name[0]

def get_enum_key_value(e):
    _r = re.compile("(XR.*) = (.*[^,])[,\n]", re.MULTILINE)
    return _r.findall(e)

def gen_function(functions):
    with XrTemplate("function_template.txt") as xr_function:
        function_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_function.cs")

        render_data = []

        for f in functions:
            #print(f)
            pass
       
        function_text = xr_function.render(render_data = render_data)

        with open(function_file_path, "w+") as f:
            f.write(function_text)
