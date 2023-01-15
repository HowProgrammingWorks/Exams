// Return an array without duplicates
'use strict';

const duplicate = (value, amount) => {
  if (N <= 0) return [];
  else {
    array = [];
    for (let i = 0; i < amount; i++) {
      array[i] = value;
    }
    return array;
  }
};

require('../Tests/duplicate.js')(duplicate);
