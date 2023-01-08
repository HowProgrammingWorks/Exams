// Get month number

// Step 2
// Rename 's' on 'month'
// Strings must use singlequote

'use strict';

const monthsArray = [
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

const monthFinder = (month) => {
  for (let i = 0; i < monthsArray.length; i++) {
    if (month.toLowerCase().startsWith(monthsArray[i])) return i + 1;
  }
  return -1;
};

require('../Tests/month.js')(monthFinder);
