// Get month number
'use strict'

const months = ['jan', 'feb', 'mar', 'apr', 'may', 'jun', 'jul', 'aug', 'sep', 'oct', 'nov', 'dec',];

const month = (s) => {
  const length = months.length;
  for (let i = 0; i < length; i++) {
    if (s.toLowerCase().startsWith(months[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(month);
