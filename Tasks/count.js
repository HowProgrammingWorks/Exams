// Sum all number values in dict
'use strict';

const sumOfNumbers = (obj) => {
  let result = 0;

  const keys = Object.keys(obj);

  keys.map((key) => {
    const value = obj[key];
    if (typeof value === 'number') result += value;
  });
  return result;
};

require('../Tests/count.js')(sumOfNumbers);
