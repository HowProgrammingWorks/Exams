'use strict';

// Get month number

//Month is fixed. Passed: 7 of 7.

const MONTHS = [
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
  const numberMonths = MONTHS.length;
  const lowerMonthName = monthName.toLowerCase();
  for (let i = 0; i < numberMonths; i++) {
    if (lowerMonthName.startsWith(MONTHS[i])) return ++i;
  }
  return -1;
};

require('../Tests/month.js')(getMonthNumber);
