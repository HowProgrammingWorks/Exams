'use strict';
// Get month number

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

const getMonthNum = (monthName) => {
  const lowerMonthName = monthName.toLowerCase();
  for (const month of months) {
    if (lowerMonthName.startsWith(month)) {
      return months.indexOf(month) + 1;
    }
  }
  return -1;
};

require('../Tests/month.js')(getMonthNum);
