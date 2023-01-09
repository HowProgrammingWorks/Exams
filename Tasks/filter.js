// Filter array by type name

'use strict'

const filter = (arr, type) => {
  const result = [];
  for (const object of arr) {
    if (typeof object === type) {
      result.push(object);
    }
  }
  for (const index of remove) arr.splice(index, 1);
  return arr;
};

require('../Tests/filter.js')(filter);
