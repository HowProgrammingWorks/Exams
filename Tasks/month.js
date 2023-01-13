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

const Month = (inputString) => {
  for (let i = 0; i < l; i++) {
    if (inputString.toLowerCase().startsWith(MONTHS[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(Month);
