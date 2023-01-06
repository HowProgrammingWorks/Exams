// Sum all number values in dict
'use strict'

const count = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  values.map((value) => {
    if (typeof value === 'number')
      sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
