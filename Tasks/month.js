'use strict';

// Get month number

const Months = [
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

const Month = (s) => {
  for (let i = 0; i < Months.length; i++) {
    if (s.toLowerCase().startsWith(Months[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(Month);
