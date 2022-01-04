'use strict';

const plane = (arr) => {
  const res = [];
  for (const val of arr) {
    if (Array.isArray(val))
      res.push(...plane(val));
    else
      res.push(val);
  }
  return res;
};
