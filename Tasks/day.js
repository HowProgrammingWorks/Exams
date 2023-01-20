// Get day number

const week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (days) => {
  let i;
  for (i = 0; i < week.length; i++) {
    if (days.startsWith(week[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
