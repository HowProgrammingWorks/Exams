// Return an array without duplicates
'use strict';

const deduplicate = ([...arr]) => {
  const set = new Set();
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    if (set.has(value)) {
      arr.splice(i, 1);
      i--;
    }
    else {
      set.add(value);
    };
  };
  return arr;
}

require('../Tests/distinct.js')(deduplicate);
