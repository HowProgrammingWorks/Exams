// Get month number
'use strict';
const months = ['jan','feb','mar','apr','may','jun','jul','aug','sep','oct','nov','dec'];

const monthNum = (yourMonth) => {
  const len = months.length;
  for (let i = 0; i < len; i++) {
    if (yourMonth.toLowerCase().startsWith(months[i])) return i + 1;
  }
  return -1;
};

const result = monthNum('february');
console.log(result);
