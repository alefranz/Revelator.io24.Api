# Revelator io24 API (Unofficial)

This project is to be able to control a Revelator io24 interface through an API.
This way we can have **automations** and **plugins** for Stream Deck, Touch Portal, Loupedeck, and more.

## Progress

- API: A lot of bugs, and missing features, but monitoring and routing works.
- Stream Deck plugin: Fat Channel Toggle, Routing and headphone sources, with status.
- Touch Portal plugin: Fat Channel Toggle, Routing and headphone sources, with status.
- Loupedeck plugin: not started.

## How to test

- Read the text on this page.
- Go to the [Releases](https://github.com/oddbear/Revelator.io24.Api/releases/tag/v0.0.2-pre) page, or click on `Releases` to the right of this page.
- Read the text on the releases page.
- Windows App:
  - Download zip file under Assets on the Releases page
  - Unzip
  - Run `Revelator.io24.Wpf.exe`
- Stream Deck plugin:
  - Download `com.oddbear.revelator.io24.streamDeckPlugin` under Assets on the Releases page
  - Install <br /> _(or unzip to plugin directory)_
- Touch Portal plugin:
  - Download `Revelator.io24.TouchPortal.tpp` under Assets on the Releases page
  - Open Touch Portal, click on settings menu and select Import plug-in... <br /> _(or unzip to plugin directory, and restart Touch Portal)_
  - Thrust the plugin, or it wont start

## Warnings

- This API is **unofficial**, at any time, a update to the Revelator io24 **can break this API**. 
- This project is in the **early stages**, and a **proof-of-concept only**, don't expect it to be stable at this point.

## About the API

The `Universal Control` and `UC Surface` apps can be used to control some devices from PreSonus. The apps uses a protocol called [UCNET](https://www.presonussoftware.com/en_US/technology) that is not well documented, and easy to use by third parties.

This project aims to document and understand the part of this protocol that is used when comunicating with the io24, and create an API that is more understandable for making plugins, automations and such. There are already similar APIs like this for some other devices, but theese does not seem to work for this particular device.
