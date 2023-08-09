import os

from jinja2 import Template

SCRIPT_PATH = os.path.dirname(os.path.realpath(__file__))

class XrTemplate(object):
    def __init__(self, _path):
        self.path = _path

    def __enter__(self):
        temp_path = os.path.join(SCRIPT_PATH, self.path)
        with open(temp_path) as r:
            template = Template("".join(r.readlines()))
            return template

    def __exit__(self, type, value, tb):
        pass