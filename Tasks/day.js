// Get day number

const Week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

_parse_day_ = (s) => {
  for (let i = 0; i < Week.length; i++) {
    if (s.startsWith(Week[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(_parse_day_);
