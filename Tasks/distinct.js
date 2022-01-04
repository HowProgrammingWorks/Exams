// Deduplicate values in array
'use strict';

const distinct = data => {
  if (!Array.isArray(data)) {
    return 'Data must be an array';
  }
  const set = new Set(); 
  for (let i = 0; i < data.length; i++) {
    if (set.has(data[i])) {
      data.splice(i, 1);
      i--;
    } else {
      set.add(data[i]);
    }
  }
  return data;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
