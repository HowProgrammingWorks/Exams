Months = [
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

Month = (s) => {
  const month = s.toLowerCase().substring(0, 3);
  const monthIndex = Months.indexOf(month);
  return monthIndex !== -1 ? monthIndex + 1 : -1;
};

require('../Tests/month.js')(Month);
