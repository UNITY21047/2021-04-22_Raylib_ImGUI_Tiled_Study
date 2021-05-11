COMPILER = dotnet

main:
	${COMPILER} build

run: main
	${COMPILER} run

rest:
	${COMPILER} restore