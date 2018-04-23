/// <binding BeforeBuild='build-webpack-debug' />
const gulp = require('gulp');
const exec = require('child_process').exec;

gulp.task('build-webpack-debug', function (done) {
	exec('"node_modules/.bin/webpack" --color --mode development --verbose', function (err, stdout, stderr) {
		console.log(stdout);
		console.error(stderr);
		done(err);
	});
});
