// Find longest string

const longest = function (line = []) {
  x = -1;
 
 for (i of line) {
    if (i.length > x) {
      x = i.length;
    } else {
      i = 0;
    }
    if (i.length >= x) {
      s = i;
    } else {
      i = -1;
    }
  }
  return s;
};

require('../Tests/longest.js')(longest);
