'use strict';

// Filter array by type name

//Filter is fixed. Passed: 5 of 5.

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
