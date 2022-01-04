// Get day number
'use strict';

// eslint-disable-next-line arrow-parens
const parseDay = (searchDay) => {
  const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
  const toLowerCaseDay = [];
  for (let i = 0; i < days.length; i++) {
    toLowerCaseDay[i] = days[i].toLowerCase();
    if (searchDay.startsWith(toLowerCaseDay[i])) return i + 1;
  }
  return -1;
};

const result = parseDay('friday');
console.log(result);
