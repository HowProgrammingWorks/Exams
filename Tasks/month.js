// Get month number
'use strict';

 const months = [
  'january',
  'february',
  'march',
  'april',
  'may',
  'june',
  'july',
  'august',
  'september',
  'october',
  'november',
  'december',
];

 const month = (s) => {
  for (let i = 0; i < months.length; i++){
    const currentMonth = months[i]
    const loweredMonth = s.toLowerCase()

    if (loweredMonth && currentMonth.indexOf(loweredMonth) >= 0) {
      return i + 1
    }
  }
  return -1
};

require('../Tests/month.js')(month);
