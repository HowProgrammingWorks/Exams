// Find longest string

const longest = function (line = []) {
  x = -1;
 
 for (i of line) {
    if (i.length > x) {
      x = i.length;
      s = i;
    }
  }
  return s;
};

require('../Tests/longest.js')(longest);
