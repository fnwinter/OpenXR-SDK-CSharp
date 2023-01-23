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


def get_function_name(f):
    _r = re.compile("(\w+(\s)?)\(", re.MULTILINE)
    m = _r.findall(f)
    return m[0][0].strip()

def get_params(f):
    _r = re.compile("\(((.|\n)*?)\)", re.MULTILINE)
    m = _r.findall(f)
    print(m[0][0])
    print("-----------")
    pass

def get_return_type(f):
    pass

def gen_function(functions):
    with XrTemplate("function_template.txt") as xr_function:
        function_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_function.cs")

        render_data = []

        for f in functions:
            print(get_function_name(f))
            pass
       
        function_text = xr_function.render(render_data = render_data)

        with open(function_file_path, "w+") as f:
            f.write(function_text)
