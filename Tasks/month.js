// Get month number
'use strict';

const months = ['jan', 'feb', 'mar', 'apr', 'may', 'jun', 'jul', 'aug', 'sep', 'oct', 'nov', 'dec'];

const monthNum = (yourMonth) => {
  for (const key of months.keys()) {
    if (yourMonth.toLowerCase().startsWith(months[key])) return key + 1;
  }
  return -1;
};

const result = monthNum('february');
console.log(result);
