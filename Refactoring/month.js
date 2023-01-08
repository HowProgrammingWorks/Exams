// Get month number

// Step 2
// Rename 's' on 'month'
// Strings must use singlequote

'use strict';

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

const Month = (month) => {
  for (let i = 0; i < Months.length; i++) {
    if (month.toLowerCase().startsWith(Months[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(Month);
