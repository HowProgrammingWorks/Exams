// Deduplicate values in array
'use strict';

const distinct = data => {
  if (!Array.isArray(data)) {
    return 'Data must be an array';
  }
  const set = new Set(data);
  const uniqueArray = Array.from(set);  
  return uniqueArray;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
