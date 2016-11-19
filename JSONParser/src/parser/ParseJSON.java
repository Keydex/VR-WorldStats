package parser;

import java.io.File;

public class ParseJSON {

	public static void main(String[] args) {
		if (args.length != 2) {
			usage();
		}
		File inputFile = new File(args[0]);
		File outputFile = new File(args[1]);
		if (outputFile.exists()) {
			outputFile.delete();
		}
		try {
			outputFile.createNewFile();
		} catch (Exception e) {
			e.printStackTrace();
		}
		parseInputFile(inputFile, outputFile);
	}

	private static void parseInputFile(File inputFile, File outputFile) {
				
	}

	private static void usage() {
		System.err.println("Usage: ParseJSON <inputFile> <outputFile>");
		System.exit(2);
	}
}
