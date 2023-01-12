'use strict';

const count = (obj) => {
 let sum = 0;
 let values = Object.values(obj);

  for (const value of values) {
    if (typeof value === 'number') sum += value;
  }
  return sum;
};

require('../Tests/count.js')(count);
