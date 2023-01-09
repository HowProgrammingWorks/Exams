'use strict';

// Get month number

//Month is fixed. Passed: 7 of 7.

const months = [
  'jan',
  'feb',
  'mar',
  'apr',
  'may',
  'jun',
  'jul',
  'aug',
  'sep',
  'oct',
  'nov',
  'dec',
];

const getMonthNumber = (monthName) => {
  const numberMonths = months.length;
  const lowerMonthName = monthName.toLowerCase();
  for (let i = 0; i < numberMonths; i++) {
    if (lowerMonthName.startsWith(months[i])) return ++i;
  }
  return -1;
};

require('../Tests/month.js')(getMonthNumber);
