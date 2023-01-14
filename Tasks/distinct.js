// Return an array without duplicates
'use strict';

const deduplicate = ([...arr]) => {
  const result = [];
  for (const value of arr) {
    if (!result.includes(value)) {
      result.push(value);
    }
  }
  return result;
}

require('../Tests/distinct.js')(deduplicate);
