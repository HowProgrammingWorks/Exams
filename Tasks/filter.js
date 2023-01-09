// Filter array by type name

'use strict'

const filter = (arr, type) => {
  const result = [];
  for (const object of arr) {
    if (typeof object === type) {
      result.push(object);
    }
  }
  return result;
};

require('../Tests/filter.js')(filter);
