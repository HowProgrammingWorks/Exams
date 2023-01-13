// Get month number
'use strict'

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

const monthNumber = (month) => {
  l = MONTHS.length;
  for (let i = 0; i < l; i++) {
    if (month.toLowerCase().startsWith(MONTHS[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(monthNumber);
