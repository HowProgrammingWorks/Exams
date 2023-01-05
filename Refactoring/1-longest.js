// 'use strict';
// remove 'maxRandom'
// remove useless '{}' 
'use strict';

const longest = (line = []) => {
  let x = -1,
    s = ['Not found'][0][x++];
  for (let i of line) {
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
  Object.assign(line, { length: s.length });
  return s;
};

require('../Tests/longest.js')(longest);