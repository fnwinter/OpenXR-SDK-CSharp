# generate c sharp file for openxr

import os
import re

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

OPENXR_H_FILE = os.path.join(SCRIPT_PATH, "c", "openxr.h")

def find_struct(data):
    _r = re.compile("typedef[ +]struct[ +][^{]+{[^}]+}.*;", re.MULTILINE)
    return _r.findall(data)

def find_enum(data):
    _r = re.compile("typedef[ +]enum[ +][^{]+{[^}]+}.*;", re.MULTILINE)
    return _r.findall(data)

def find_macro(data):
    pass

def find_function(data):
    pass

if __name__ == '__main__':
    print("# generate c sharp file for openxr")

    data = None
    with open(OPENXR_H_FILE) as f:
        data = "".join(f.readlines())
