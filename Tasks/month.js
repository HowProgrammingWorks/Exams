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
  const lowerCase = month.toLowerCase();
  for (let i = 0; i < arrayOfMonths.length; i++) {
    if (lowerCase.startsWith(arrayOfMonths[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(getNumOfMonth);
