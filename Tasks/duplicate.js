'use strict';

// Fill array with given value N times

{
  const fillArray = (value, n = 0) => {
    const result = [];
    for (let i = 0; i < n; i++) {
      result[i] = value;
    }
    return result;
  };

  const result = fillArray('abc', 5);
  console.log(result);
}

// Inline variant
{
  const fillArray = (value, n = 0) => new Array(n).fill(value);

  const result = fillArray('abc', 5);
  console.log(result);
}
