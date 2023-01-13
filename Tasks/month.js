'use strict';

// Get month number

const arrayOfMonths = [
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

const getNumOfMonth = (month) => {
  for (let i = 0; i < arrayOfMonths.length; i++) {
    if (month.toLowerCase().startsWith(arrayOfMonths[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(getNumOfMonth);
