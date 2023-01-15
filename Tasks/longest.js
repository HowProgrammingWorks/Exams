// Find longest string
'use strict';

const longest = function (line = []) {
  let x = -1;
  let s = undefined;
  for (const i of line) {
    if (i.length > x) {
      x = i.length;
      s = i;
    }
  }
  return s;
};

require('../Tests/longest.js')(longest);