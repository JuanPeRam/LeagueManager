<!DOCTYPE html>
<html>
<head>
	<title>Tournament Bracket</title>
	<style>
		.bracket {
			display: flex;
			flex-direction: column;
			align-items: center;
			font-family: Arial, sans-serif;
			font-size: 16px;
			line-height: 1.5;
		}
		.round {
			display: flex;
			flex-direction: column;
			align-items: center;
			margin-bottom: 30px;
		}
		.matchup {
			display: flex;
			flex-direction: row;
			align-items: center;
			justify-content: space-between;
			width: 500px;
			height: 50px;
			margin-bottom: 10px;
		}
		.team {
			display: flex;
			align-items: center;
			justify-content: center;
			width: 150px;
			height: 50px;
			background-color: #f2f2f2;
			border: 2px solid #ddd;
			border-radius: 5px;
		}
		.winner {
			background-color: #4CAF50;
			color: white;
		}
	</style>
</head>
<body>
	<div class="bracket">
		<div class="round">
			<div class="matchup">
				<div class="team winner">Team ZZZ</div>
				<div class="team">Team B</div>
			</div>
			<div class="matchup">
				<div class="team">Team C</div>
				<div class="team winner">Team D</div>
			</div>
		</div>
		<div class="round">
			<div class="matchup">
				<div class="team winner">Team A</div>
				<div class="team">Team D</div>
			</div>
		</div>
		<div class="round">
			<div class="matchup">
				<div class="team winner">Team A</div>
			</div>
		</div>
	</div>
</body>
</html>
