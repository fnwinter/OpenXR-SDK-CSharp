import os
import re

from templates.template import XrTemplate

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

ignore_list = ["OPENXR_H_"]

def get_key_name(macro):
    return macro[0], macro[2]

def is_number(value):
    try:
        int(value)
        return True
    except ValueError:
        return False

def is_string(value):
    if value.find("\"") != -1:
        return True
    return False

def gen_macro(macros):
    with XrTemplate("macro_template.txt") as xr_macro:
        macro_file_path = os.path.join(SCRIPT_PATH, "csharp", "openxr_macro.cs")

        render_data = []
        for m in macros:
            key, value = get_key_name(m)
            
            if key == "" or value == "" or key in ignore_list:
                continue

            macro_string = ""
            if is_string(value):
                macro_string = f"const static string {key} = {value};"
                render_data.append(macro_string)

            if is_number(value):
                macro_string = f"const static int {key} = {value};"
                render_data.append(macro_string)
        
        macro_text = xr_macro.render(render_data = render_data)

        with open(macro_file_path, "w+") as f:
            f.write(macro_text)
