// Get month number
'use strict';
const parseMonth = month => {

  for (let i = 0; i < months.length; i++) {

    const monthsPrefixes = months[i].toLowerCase();
    if (month.startsWith(monthsPrefixes))
      return i + 1;
  }
};

const months = ['jan', 'feb', 'mar', 'apr', 'may', 'jun', 'jul', 'aug', 'sep', 'oct', 'nov', 'dec'];
const result = parseMonth('may');
console.log(result);
