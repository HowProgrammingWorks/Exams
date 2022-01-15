"use strict";

// Fill array with given value N times

{
  const fillArray = (value, n) => {
    const res = [];
    for (let i = 0; i < n; i++) {
      res[i] = value;
    }
    return res;
  };

  const result = fillArray("abc", 5);
  console.log(result);
}

// Inline variant
{
  const fillArray = (value, n) => new Array(n).fill(value);

  const result = fillArray("abc", 5);
  console.log(result);
}
