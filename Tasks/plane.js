'use strict';

const plane = (arr) => {
  const res = [];
  for (const val of arr)
    Array.isArray(val) ? res.push(...plane(val)) : res.push(val);
  return res;
};
