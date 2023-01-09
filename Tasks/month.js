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
  const lowerNameMonth = nameMonth.toLowerCase();
  for (let i = 0; i < numberMonths; i++) {
    if (lowerNameMonth.startsWith(MONTHS[i])) return ++i;
  }
  return -1;
};

require('../Tests/month.js')(getNumberMonth);
