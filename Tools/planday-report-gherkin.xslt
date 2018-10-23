<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:foo="http://www.foo.org/" xmlns:bar="http://www.bar.org">
    <xsl:output method="text" version="2.0" encoding="utf-16"/>
    <xsl:template match="/">
        Feature: Some terse yet descriptive text of what is desired
        Textual description of the business value of this feature
        Business rules that govern the scope of the feature
        Any additional information that will make the feature easier to understand
        <xsl:for-each select="assemblies/assembly/collection/test">
            <xsl:value-of select="@name" />&#160;
            <!---->
            <!--<xsl:variable name="currentNode" select="." />-->
            <!--<xsl:variable name="gherkinPart" select="substring-after($currentNode/@name, '] ')" />-->
            <!---->
            <!--Scenario: <xsl:value-of select="translate($whenPart,'_',' ')" />-->
              <!--Given <xsl:value-of select="substring-before($currentNode/ancestor-or-self::concern[1]/@name, ' ')" />&#160;<xsl:value-of select="./@name" />-->
              <!--When <xsl:value-of select="translate($whenPart,'_',' ')" />-->
              <!--<xsl:for-each select="./specification">-->
                  <!--<xsl:choose>-->
                      <!--<xsl:when test="position()=1">-->
              <!--Then It <xsl:value-of select="@name" />-->
                      <!--</xsl:when>-->
                      <!--<xsl:otherwise>-->
                <!--And It <xsl:value-of select="@name" />-->
                      <!--</xsl:otherwise>-->
                  <!--</xsl:choose>-->
              <!--</xsl:for-each>-->
            <!---->
            <!---->
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>