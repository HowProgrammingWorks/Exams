'use strict';

// Filter array by type name

//Filter is fixed. Passed: 5 of 5.

const filter = (arr, type) => {
  const result = [];
  for (const element of arr) {
    if (typeof element === type) {
      result.push(element);
    }
  }
  return result;
};

require('../Tests/filter.js')(filter);
