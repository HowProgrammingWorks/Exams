'use strict';
// Get month number

const monthsOfYear = [
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

const getMonthNum = (monthName) => {
  
  for (const month of monthsOfYear) {
    if (monthName.toLowerCase().startsWith(month)) {
      return monthsOfYear.indexOf(month) + 1;
    }
  }
  return -1;
};

require('../Tests/month.js')(getMonthNum);
