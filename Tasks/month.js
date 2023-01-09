// Get month number

'use strict';

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

const getNumberMonth = (nameMonth) => {
  const numberMonths = MONTHS.length;
  for (let i = 0; i < numberMonths; i++) {
    if (nameMonth.toLowerCase().startsWith(MONTHS[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(getNumberMonth);
