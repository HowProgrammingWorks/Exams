// Get day number
'use strict';

const getDayNumber = function(text) {
  const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
  for (let i = 0; i < days.length; i++) {
    if (text !== null && text.toLowerCase().startsWith(days[i].toLowerCase())) {
      return i + 1;
    }
  }
};

const result = getDayNumber('friday');
console.log(result);
