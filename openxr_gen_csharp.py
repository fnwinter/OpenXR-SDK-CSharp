# generate c sharp file for openxr

import os
import re

from gen_structure import gen_structure
from gen_enum import gen_enum

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))
OPENXR_HEADER_FILE = os.path.join(SCRIPT_PATH, "c", "openxr.h")

def find_struct(data):
    _r = re.compile("typedef[ +]struct[ +][^{|^#]+{[^}]+}.*;", re.MULTILINE)
    return _r.findall(data)

def find_enum(data):
    _r = re.compile("typedef[ +]enum[ +][^{]+{[^}]+}.*;", re.MULTILINE)
    return _r.findall(data)

def find_macro(data):
    _r = re.compile("#define(?:.*\\\n.*|.*)", re.MULTILINE)
    return _r.findall(data)

def find_const_values(data):
    _r = re.compile("static const .*", re.MULTILINE)
    return _r.findall(data)

def find_function(data):
    _r = re.compile("XRAPI_ATTR[^;]*;", re.MULTILINE)
    return _r.findall(data)

if __name__ == '__main__':
    print("# generate c sharp file for openxr")

    lines = None 
    with open(OPENXR_HEADER_FILE) as f:
        lines = "".join(f.readlines())

        gen_structure(find_struct(lines))

        gen_enum(find_enum(lines))
