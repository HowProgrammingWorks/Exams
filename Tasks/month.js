// Get month number

'use strict';

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

const getMonthNumber = (month) => {
  for (let i = 0; i < months.length; i++) {
    if (month.toLowerCase().startsWith(months[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(getMonthNumber);
