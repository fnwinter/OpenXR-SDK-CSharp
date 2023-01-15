# generate c sharp file for openxr

import os
import re

from gen_structure import gen_structure
from gen_enum import gen_enum

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

OPENXR_H_FILE = os.path.join(SCRIPT_PATH, "c", "openxr.h")

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

    data = None 
    with open(OPENXR_H_FILE) as f:
        data = "".join(f.readlines())

        structures = find_struct(data)
        for s in structures:
            #gen_structure(s)
            pass

        enums = find_enum(data)
        gen_enum(enums)
